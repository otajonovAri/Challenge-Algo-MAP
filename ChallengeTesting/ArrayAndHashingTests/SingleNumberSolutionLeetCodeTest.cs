using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class SingleNumberSolutionLeetCodeTest
{
    private readonly SingleNumberLeetCode _solution = new SingleNumberLeetCode();

    [Fact]
    public void SingleNumber_ReturnsCorrectResult()
    {
        // Arrange
        var nums = new int[] { 2, 2, 1 };
        var expected = 1;

        // Act
        var result = _solution.SingleNumber(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleNumberLinq_ReturnsCorrectResult()
    {
        // Arrange
        var nums = new int[] { 4, 1, 2, 1, 2 };
        var expected = 4;
        // Act
        var result = _solution.SingleNumberLinq(nums);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleNumberHashSet_ReturnsCorrectResult()
    {
        // Arrange
        var nums = new int[] { 1, 2, 3, 2, 1 };
        var expected = 3;
        // Act
        var result = _solution.SingleNumberHashSet(nums);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleNumber_EmptyArray_ReturnsZero()
    {
        // Arrange
        var nums = new int[] { };
        var expected = 0;
        // Act
        var result = _solution.SingleNumber(nums);
        // Assert
        Assert.Equal(expected, result);
    }
}
