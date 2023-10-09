namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region OrderByQuery
    /// <summary>
    /// Order products by Name
    /// </summary>
    public List<Product> OrderByQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.ListPrice
              select prod
              ).ToList();

      return list;
    }
    #endregion

    #region OrderByMethod
    /// <summary>
    /// Order products by Name
    /// </summary>
    public List<Product> OrderByMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
     list = products
         .Select(prod => prod) // Optional
         .OrderBy(prod=>prod.ListPrice).ToList();

      return list;
    }
    #endregion

    #region OrderByDescendingQuery Method
    /// <summary>
    /// Order products by name in descending order
    /// </summary>
    public List<Product> OrderByDescendingQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.ListPrice descending 
              select prod).ToList();

      return list;
    }
    #endregion

    #region OrderByDescendingMethod Method
    /// <summary>
    /// Order products by name in descending order
    /// </summary>
    public List<Product> OrderByDescendingMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.OrderByDescending(prod => prod.ListPrice).ToList();

      return list;
    }
    #endregion

    #region OrderByTwoFieldsQuery Method
    /// <summary>
    /// Order products by Color descending, then Name
    /// </summary>
    public List<Product> OrderByTwoFieldsQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      // Order by Color first, and then Name
      list = (from prod in products
              orderby prod.Color descending, prod.Name ascending // ascending is a default, no need to add it but you can
              select prod).ToList();

      return list;
    }
    #endregion

    #region OrderByTwoFieldsMethod Method
    /// <summary>
    /// Order products by Color descending, then Name
    /// </summary>
    public List<Product> OrderByTwoFieldsMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.OrderByDescending(prod => prod.Color).ThenBy(prod => prod.Name).ToList();

      return list;
    }
    #endregion

    #region OrderByTwoFieldsDescMethod Method
    /// <summary>
    /// Order products by Color descending, then Name Descending
    /// </summary>
    public List<Product> OrderByTwoFieldsDescMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products
          .OrderByDescending(prod => prod.Color)
          .ThenByDescending(prod => prod.Name)
          .ToList();
      return list;
    }
    #endregion

  }
}
