namespace FIBA3x3.Interview.WorkSample.Data;

/// <summary>
/// Represents an address (e.g. of an Event)
/// </summary>
public class Address
{
    /// <summary>
    /// Custom address information content like street, place, description
    /// </summary>
    public string Information { get; set; }
    
    /// <summary>
    /// The name of the city
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// The iso 2 code of the country the address belongs to
    /// </summary>
    public string CountryIso2 { get; set; }
}