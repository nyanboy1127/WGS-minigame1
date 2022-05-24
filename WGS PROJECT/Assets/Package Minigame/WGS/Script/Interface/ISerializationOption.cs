
namespace RunMinigames.Interface
{
    public interface ISerializationOption
    {
        string ContentType { get; }
        T Deserialize<T>(string text);
    }
}