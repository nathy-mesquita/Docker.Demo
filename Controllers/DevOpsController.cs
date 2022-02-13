using Microsoft.AspNetCore.Mvc;

namespace Docker.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class DevOpsController : ControllerBase
{
    private readonly ILogger<DevOpsController> _logger;
    public DevOpsController(ILogger<DevOpsController> logger) => _logger = logger;

    [HttpGet(Name = "Get")]
    public IEnumerable<DevOps> Get()
    {
        return Enumerable.Range(1, 1).Select(index => new DevOps
        {
            FundamentosDevOps = FundamentosTag,
            CICDPrincipaisFerramentas = FerramentasTag,
            SelfHosted = SelfHostedTag,
            SaaS = SaaSTag,
            ComputacaoEmNuvem = ComputacaoEmNuvemTag
        })
        .ToArray();
    }


#region  Statics
    private static readonly string[] FundamentosTag = new[]
    {
        "CULTURE", "AUTOMATION", "MEANSUREMENT", "SHARING", "CAMS"
    };

    private static readonly string[] FerramentasTag = new[]
    {
        "CI- Continuous Integration", "CD- Continuous Delivery", "PlayRight", "Trunk-Based", "Artefato do Build", "Self-hosted", "Software as a Service (SaaS)", "Provedores de Computação na Nuvem", "Repositório de código"
    };

    private static readonly string[] SelfHostedTag = new[]
    {
        "Jenkins", "Bamboo", "TeamCity"
    };
    private static readonly string[] SaaSTag = new[]
    {
        "TravisCI", "CircleCI"
    };
    private static readonly string[] ComputacaoEmNuvemTag = new[]
    {
        "Azure Pipelines ", "Github Actions", "Gitlab CI"
    };

#endregion

}
