namespace Ravenhill.Model.Bib;

public record WebsiteResource(
    string Title,
    string Url
) : IBibliographyResource;