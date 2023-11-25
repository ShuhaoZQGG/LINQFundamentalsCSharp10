using System.Linq;

namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region TakeQuery
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products 
              orderby prod.Name
              select prod)
          .Take(5)
          .ToList();

      return list;
    }
    #endregion

    #region TakeMethod
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
     list = products.OrderBy(prod => prod.Name).Take(5).ToList();

      return list;
    }
    #endregion

    #region TakeRangeQuery
    /// <summary>
    /// Use Take() to select a specified number of items from a collection using the Range operator
    /// </summary>
    /// Specifies the start and end of a range
    /// Take(5..8) gives us elements 6, 7 and 8
    /// Take(..4) goes from element 0 to 3
    /// Take(10..) goes from element 11 through the end
    /// Take(^5..^2) goes from the 5th element from end to 3rd from end
    public List<Product> TakeRangeQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Name
              select prod)
          //.Take(5..8)
          //.Take(..4)
          //.Take(10..)
          .Take(^5..^2)
          .ToList();
     
      return list;
    }
    #endregion

    #region TakeRangeMethod
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeRangeMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = products
          .OrderBy(prod => prod.Name)
          .Take(10..)
          //.Take(..4)
          //.Take(5..8)
          //.Take(^5..^2)
          .ToList();

      return list;
    }
    #endregion

    #region TakeWhileQuery
    /// <summary>
    /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> TakeWhileQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Name
              select prod).TakeWhile(p => p.Name.StartsWith("A"))
          .ToList();

      return list;
    }
    #endregion

    #region TakeWhileMethod
    /// <summary>
    /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> TakeWhileMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
     list = products.OrderBy(p => p.Name)
         .TakeWhile(p => p.Name.StartsWith("A"))
         .ToList();

      return list;
    }
    #endregion

    #region SkipQuery
    /// <summary>
    /// Use Skip() to move past a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> SkipQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Name
              select prod)
          .Skip(30)
          .ToList();

      return list;
    }
    #endregion

    #region SkipMethod
    /// <summary>
    /// Use Skip() to move past a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> SkipMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.OrderBy(p => p.Name)
          .Skip(30)
          .Take(5)
          .ToList();

      return list;
    }
    #endregion

    #region SkipWhileQuery
    /// <summary>
    /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> SkipWhileQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Name
              select prod)
          .SkipWhile(p => p.Name.StartsWith("A"))
          .ToList();

      return list;
    }
    #endregion

    #region SkipWhileMethod
    /// <summary>
    /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> SkipWhileMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();
        
      // Write Method Syntax Here
      list = products
          .OrderBy(p => p.Color)
          .SkipWhile(p => p.Color.StartsWith("B"))
          .ToList();
      return list;
    }
    #endregion

    #region DistinctQuery
    /// <summary>
    /// The Distinct() operator finds all unique values within a collection.
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> DistinctQuery()
    {
      List<Product> products = GetProducts();
      List<string> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Color
              select prod.Color)
          .Distinct()
          .OrderByDescending(c => c.Length)
          .ToList();

      return list;
    }
    #endregion

    #region DistinctMethod
    /// <summary>
    /// The Distinct() operator finds all unique values within a collection.
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> DistinctMethod()
    {
      List<Product> products = GetProducts();
      List<string> list = new();

      // Write Method Syntax Here
      list = products.Select(p => p.Color).Distinct().OrderBy(p => p).ToList();

      return list;
    }
    #endregion

    #region DistinctByQuery
    public List<Product> DistinctByQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
          select prod)
          .DistinctBy(p => p.Color)
          .ToList();

      return list;
    }
    #endregion

    #region DistinctByMethod
    public List<Product> DistinctByMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.DistinctBy(p => p.Color).ToList();

      return list;
    }
    #endregion

    #region ChunkQuery
    /// <summary>
    /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
    /// </summary>
    public List<Product[]> ChunkQuery()
    {
      List<Product> products = GetProducts();
      List<Product[]> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              select prod)
          .Chunk(8)
          .ToList();
      return list;
    }
    #endregion

    #region ChunkMethod
    /// <summary>
    /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
    /// </summary>
    public List<Product[]> ChunkMethod()
    {
      List<Product> products = GetProducts();
      List<Product[]> list = new();

      // Write Method Syntax Here
      list = products.Chunk(10).ToList();

      return list;
    }
    #endregion
  }
}
