using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class StuffWithRend : RenderPipeline
{
    public StuffWithRend()
    {
    }

    //SRP to submit changes to Render Pipeline
    //context is the current state of Render Pipeline

    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {

        //CommandBuffer holds changes

        var cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true, true, Color.blue);
        context.ExecuteCommandBuffer(cmd);
        cmd.Release();

        context.Submit();
    }




    
}
