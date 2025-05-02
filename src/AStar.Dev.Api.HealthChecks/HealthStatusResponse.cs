namespace AStar.Dev.Api.HealthChecks;

/// <summary>
///     The <see cref="HealthStatusResponse" /> class contains a strongly-typed response for the Health Checks to use
/// </summary>
public sealed record HealthStatusResponse
{
    /// <summary>
    ///     Gets or sets the name of the Health Check
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the description of the Health Status response
    /// </summary>
    public string? Description { get; set; } = "Unable to retrieve the description of the Health Status";

    /// <summary>
    ///     Gets or sets the Status of the Health Status response
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the milliseconds the Health Check took to complete
    /// </summary>
    public double DurationInMilliseconds { get; set; }

    /// <summary>
    ///     TBH, not sure if this is populated anywhere at the time of writing
    /// </summary>
    public IReadOnlyDictionary<string, object>? Data { get; set; }

    /// <summary>
    ///     Gets or sets the <see cref="Exception" /> (or derived type) encountered during the Health Check call
    /// </summary>
    public string? Exception { get; set; } = string.Empty;
}
