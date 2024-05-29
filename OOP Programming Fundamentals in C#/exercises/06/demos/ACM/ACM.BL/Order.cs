using System;

namespace ACM.BL
{
  public class Order
  {
    public Order()
    {

    }
    public Order(int orderId)
    {
      OrderId = orderId;
    }

    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; private set; }

    /// <summary>
    /// Validates the order data.
    /// </summary>
    /// <returns></returns>
    public bool Validate()
    {
      var isValid = true;

      if (OrderDate == null) isValid = false;

      return isValid;
    }
  }
}
