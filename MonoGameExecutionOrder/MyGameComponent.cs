using System;
using Microsoft.Xna.Framework;
using MyGameExecution;

public class MyGameComponent : GameComponent
{
    public MyGameComponent(Game game) : base(game)
    {
        // constructor logic here
        Game1.LogMessage("MyGameComponent - Start");
        game.Components.Add(this);
    }

    public override void Initialize()
    {
        Game1.LogMessage("MyGameComponent - Initialize");
        // initialization logic here
        base.Initialize();
    }

    public override void Update(GameTime gameTime)
    {
        Game1.LogMessage("MyGameComponent - Update");
        // update logic here
        base.Update(gameTime);
    }

    protected override void Dispose(bool disposing)
    {
        Game1.LogMessage("MyGameComponent - Dispose");
        base.Dispose(disposing);
    }

    protected override void OnEnabledChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyGameComponent - OnEnabledChanged");
        base.OnEnabledChanged(sender, args);
    }

    protected override void OnUpdateOrderChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyGameComponent - OnUpdateOrderChanged");
        base.OnUpdateOrderChanged(sender, args);
    }
}
