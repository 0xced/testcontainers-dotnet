namespace Testcontainers.Xunit.Tests;

public class AlphabeticalTestCaseOrderer : ITestCaseOrderer
{
    public IReadOnlyCollection<TTestCase> OrderTestCases<TTestCase>(IReadOnlyCollection<TTestCase> testCases) where TTestCase : notnull, ITestCase
    {
        return testCases.OrderBy(testCase => testCase.TestMethod?.MethodName).ToList();
    }
}