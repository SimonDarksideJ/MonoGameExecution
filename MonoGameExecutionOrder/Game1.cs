using System;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGameExecution;

public class Game1 : Game
{
    private static readonly StringBuilder logSB = new();

    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        LogMessage("Game1 - Start");

        AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        var MyGameComponent = new MyGameComponent(this);
        var MyDrawableGameComponent = new MyDrawableGameComponent(this);
    }

    protected override void Initialize()
    {
        LogMessage("Game1 - Initialize");

        base.Initialize();
    }

    protected override void LoadContent()
    {
        LogMessage("Game1 - LoadContent");

        _spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        LogMessage("Game1 - Update");

        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        base.Update(gameTime);
    }

    protected override bool BeginDraw()
    {
        LogMessage("Game1 - BeginDraw");

        return base.BeginDraw();
    }

    protected override void Draw(GameTime gameTime)
    {
        LogMessage("Game1 - Draw");

        GraphicsDevice.Clear(Color.MonoGameOrange);

        base.Draw(gameTime);
    }

    protected override void EndDraw()
    {
        LogMessage("Game1 - EndDraw");

        base.EndDraw();
    }

    protected override void UnloadContent()
    {
        LogMessage("Game1 - UnloadContent");

        base.UnloadContent();
    }

    protected override void OnActivated(object sender, EventArgs args)
    {
        LogMessage("Game1 - OnActivated");

        base.OnActivated(sender, args);
    }

    protected override void OnDeactivated(object sender, EventArgs args)
    {
        LogMessage("Game1 - OnDeactivated");

        base.OnDeactivated(sender, args);
    }

    protected override void OnExiting(object sender, EventArgs args)
    {
        LogMessage("Game1 - OnExiting");

        base.OnExiting(sender, args);
    }

    protected override void Dispose(bool disposing)
    {
        LogMessage("Game1 - Dispose");

        base.Dispose(disposing);
    }

    protected override void BeginRun()
    {
        LogMessage("Game1 - BeginRun");

        base.BeginRun();
    }

    protected override void EndRun()
    {
        LogMessage("Game1 - EndRun");

        base.EndRun();
    }

    public static void LogMessage(string message)
    {
        Console.WriteLine($"{DateTime.UtcNow} - {message}");
        logSB.AppendLine($"{message},{DateTime.UtcNow}");
    }

    private void OnProcessExit(object sender, EventArgs e)
    {
        string path = $"./MonoGameExecution.csv";

        using StreamWriter sw = new(path);
        sw.WriteLine("Event, Time"); // write the header row

        // write each row of data
        string[] fields = logSB.ToString().Split('\n');
        foreach (string field in fields)
        {
            sw.WriteLine(field);
        }
    }
}
