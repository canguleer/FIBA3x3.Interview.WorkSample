using System.Text.Json;

namespace FIBA3x3.Interview.WorkSample.Data
{
    /// <summary>
    /// The overall data service providing access to the related data sources used in this project
    /// </summary>
    public class DataService
    {
        /// <summary>
        /// Queries all countries relevant for this sample
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Country>?> GetCountriesAsync()
        {
            return JsonSerializer.Deserialize<IEnumerable<Country>>(await File.ReadAllTextAsync("Data/Country.json"));
        }

        /// <summary>
        /// Queries all <see cref="Event"/>s relevant for this sample
        /// </summary>
        /// <returns><see cref="IEnumerable{T}"/> of type <see cref="Event"/> providing all events relevant for this sample</returns>
        public async Task<IEnumerable<Event>?> GetEventsAsync()
        {
            return JsonSerializer.Deserialize<IEnumerable<Event>>(await File.ReadAllTextAsync("Data/Events.json"));
        }
    }
}