﻿using System;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.ManagedElasticsearch.Clusters;
using Tests.Framework.MockData;
using Xunit;

namespace Tests.Search.Explain
{
	public class ExplainApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, IExplainResponse<Project>, IExplainRequest<Project>, ExplainDescriptor<Project>, ExplainRequest<Project>>
	{
		public ExplainApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override LazyResponses ClientUsage() => Calls(
			fluent: (c, f) => c.Explain(_project, f),
			fluentAsync: (c, f) => c.ExplainAsync(_project, f),
			request: (c, r) => c.Explain(r),
			requestAsync: (c, r) => c.ExplainAsync(r)
		);

		protected override int ExpectStatusCode => 200;
		protected override bool ExpectIsValid => true;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override string UrlPath => $"/project/doc/{UrlEncode(Project.Instance.Name)}/_explain?_source=true";

		protected override bool SupportsDeserialization => false;

		protected override ExplainDescriptor<Project> NewDescriptor() => new ExplainDescriptor<Project>(_project);

		private Project _project = new Project { Name = Project.Instance.Name };

		protected override object ExpectJson => new
		{
			query = new
			{
				match = new
				{
					name = new
					{
						query = Project.Instance.Name
					}
				}
			}
		};

		protected override Func<ExplainDescriptor<Project>, IExplainRequest<Project>> Fluent => e => e
			.SourceEnabled("true") //TODO this should be generated as a bool
			.Query(q => q
				.Match(m => m
					.Field(p => p.Name)
					.Query(Project.Instance.Name)
				)
			);

		protected override ExplainRequest<Project> Initializer => new ExplainRequest<Project>(_project)
		{
			SourceEnabled = new [] { "true" },
			Query = new QueryContainer(new MatchQuery
			{
				Field = "name",
				Query = Project.Instance.Name
			})
		};

		protected override void ExpectResponse(IExplainResponse<Project> response)
		{
			response.IsValid.Should().BeTrue();
			response.Matched.Should().BeTrue();
			response.Get.Should().NotBeNull();
			response.Get.Source.ShouldAdhereToSourceSerializerWhenSet();
		}
	}
}
