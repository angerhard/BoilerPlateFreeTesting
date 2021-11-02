# BoilerPlateFreeTesting
Test for proving Issue on BoilerPlateFree

This solution is based on a service that calls a repository. Both services are initialised by BoilerPlateFree. The expectation is that the repository is injected into the service.

When I start Program.cs, I get an exception in the following line when calling the TestService because the TestRepository has not been initialised:

```csharp
var testData = _testRepository.getTestData();
```