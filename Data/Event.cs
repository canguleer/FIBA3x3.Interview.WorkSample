namespace FIBA3x3.Interview.WorkSample.Data;

/// <summary>
/// Represents a single event
/// </summary>
public class Event
{
    /// <summary>
    /// The name of the event
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The start date/time of the event
    /// </summary>
    public DateTime Start { get; set; }

    /// <summary>
    /// The end date/time of the event
    /// </summary>
    public DateTime End { get; set; }

    /// <summary>
    /// A HTML string covering additional information for the event
    /// </summary>
    public string AdditionalInformation { get; set; }

    /// <summary>
    /// The address location of the event
    /// </summary>
    public Address Address { get; set; }
}