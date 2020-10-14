using System.Collections;
using System.Collections.Generic;
using IronRuby;
using Microsoft.Scripting.Hosting;
using UnityEngine;

public class IrbTest : MonoBehaviour
{
    //Step 1: 
    //Creating a new script runtime   
    static readonly ScriptRuntime ironRubyRuntime = Ruby.CreateRuntime();

    //Step 2:
    //Load the Ruby file/script into the memory
    //Should be resolve at runtime
    readonly dynamic loadIRuby = ironRubyRuntime.UseFile(@"add.rb");

    void Start()
    {
        Debug.LogFormat("Addition result from Iron Ruby method for {0} and {1}", 100, 200);
        Debug.LogFormat("Addition result from Iron Ruby method for {0} and {1} is {2}", 100, 200, loadIRuby.add(100, 200));
    }

    public void startRB()
    {
        Debug.LogFormat("Addition result from Iron Ruby method for {0} and {1} is {2}", 100, 200, loadIRuby.add(100, 200));
    }
}
