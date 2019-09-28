using UnityEngine;

public class ConsoleSystemFactory<TPs4, TXbox, TBase> 
    where TPs4 : TBase, new()
    where TXbox : TBase, new()
{
    public static TPs4 CreatePs4()
    {
        return new TPs4();
    }
    
    public static TXbox CreateXbox()
    {
        return new TXbox();
    }

    public static TBase CreateSystem(RuntimePlatform platform)
    {
        if(platform != RuntimePlatform.PS4 || platform != RuntimePlatform.XboxOne)
            Debug.LogError("Platform not supported: "+platform);
        
        if (platform == RuntimePlatform.PS4)
            return CreatePs4();
        
        return CreateXbox();
    }
}
