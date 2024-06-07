namespace Ravenhill.Model;

public class SharepointResource(string id) {
    public string Id => $"{Base}{id}";

    private const string Base = "https://uchile-my.sharepoint.com/:p:/g/personal/ignacio_slater_uchile_cl";
}