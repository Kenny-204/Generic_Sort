namespace Generic_Sort.Tests;

using Sorting;

public class UnitTest1
{
    [Fact]
    public void GenericSort_NormalIntList_SortsCorrectly()
    {

        // Arrange
        var testList = new List<int> { 6, 5, 4, 3, 2, 1 };
        var expected = new List<int> { 1, 2, 3, 4, 5, 6 };
        // Act
        var result = Sorter.GenericSort(testList);

        // Assert
        Assert.Equal(expected, result);

    }

    
}