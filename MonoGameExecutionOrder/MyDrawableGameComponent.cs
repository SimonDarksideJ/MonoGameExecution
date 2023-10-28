using System;
using Microsoft.Xna.Framework;
using MyGameExecution;

public class MyDrawableGameComponent : DrawableGameComponent
{
    public MyDrawableGameComponent(Game game) : base(game)
    {
        // constructor logic here
        Game1.LogMessage("MyDrawableGameComponent - Start");
        game.Components.Add(this);
    }

    public override void Initialize()
    {
        Game1.LogMessage("MyDrawableGameComponent - Initialize");
        // initialization logic here
        base.Initialize();
    }

    protected override void LoadContent()
    {
        Game1.LogMessage("MyDrawableGameComponent - LoadContent");
        // load content here
        base.LoadContent();
    }

    public override void Update(GameTime gameTime)
    {
        Game1.LogMessage("MyDrawableGameComponent - Update");
        // update logic here
        base.Update(gameTime);
    }

    public override void Draw(GameTime gameTime)
    {
        Game1.LogMessage("MyDrawableGameComponent - Draw");
        // draw logic here
        base.Draw(gameTime);
    }

    protected override void UnloadContent()
    {
        Game1.LogMessage("MyDrawableGameComponent - UnloadContent");
        base.UnloadContent();
    }

    protected override void Dispose(bool disposing)
    {
        Game1.LogMessage("MyDrawableGameComponent - Dispose");
        base.Dispose(disposing);
    }

    protected override void OnDrawOrderChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyDrawableGameComponent - OnDrawOrderChanged");
        base.OnDrawOrderChanged(sender, args);
    }

    protected override void OnEnabledChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyDrawableGameComponent - OnEnabledChanged");
        base.OnEnabledChanged(sender, args);
    }

    protected override void OnUpdateOrderChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyDrawableGameComponent - OnUpdateOrderChanged");
        base.OnUpdateOrderChanged(sender, args);
    }

    protected override void OnVisibleChanged(object sender, EventArgs args)
    {
        Game1.LogMessage("MyDrawableGameComponent - OnVisibleChanged");
        base.OnVisibleChanged(sender, args);
    }
}
