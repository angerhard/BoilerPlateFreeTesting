using BoilerplateFree;
using Microsoft.Extensions.Logging;

namespace BoilerPlateFreeTesting
{
    [AutoGenerateConstructor]
    public partial class TestService
    {
        private readonly TestRepository _testRepository;
        private readonly Logger<TestService> _logger;

        public void runService()
        {
            var testData = _testRepository.getTestData();
            _logger.LogInformation("giving out testdata: {}", testData);
        }
    }
}