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
    [Fact]
    public void GenericSort_EmptyList_NoError()
    {
        // Arrange
        var emptyList = new List<int>();
        // Act
        var result = Sorter.GenericSort(emptyList);
        // Assert

        Assert.Empty(result);
    }
    [Fact]

    public void GenericSort_NullList_NoError()
    {
        // Arrange
        var list = (List<int>)null;

        // Act
        // var result = Sorter.GenericSort(list);
        // Assert
        Assert.Throws<ArgumentNullException>(() => Sorter.GenericSort(list));

    }
    [Fact]
    public void GenericSort_SingleItem_ReturnsUnchanged()
    {
        // Arrange
        var singleItemList = new List<int> { 1 };
        // Act
        var result = Sorter.GenericSort(singleItemList);
        var expected = singleItemList[0];
        // Assert
        Assert.Equal(result[0], expected);
    }
    [Fact]
    public void GenericSort_StringList_SortsCorrectly()
    {
        // Arrange
        var stringList = new List<string> { "zade", "yem", "rate", "ate" };
        var expected = new List<string> { "ate", "rate", "yem", "zade" };
        // Act
        var result = Sorter.GenericSort(stringList);
        // Assert
        Assert.Equal(result, expected);
    }
}