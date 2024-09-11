﻿//using OpenQA.Selenium.Playwright;
//using OpenQA.Selenium.Playwright.Interactions;
//using OpenQA.Selenium.Interactions;

//using PointerInputDevice = OpenQA.Selenium.Playwright.Interactions.PointerInputDevice;

//namespace DeviceRunners.UIAutomation.Playwright;

//public class PlaywrightClickCoordinatesCommand : PlaywrightElementCommand
//{
//	public PlaywrightClickCoordinatesCommand()
//		: base(CommonCommandNames.ClickCoordinates)
//	{
//	}

//	public override object? Execute(PlaywrightAutomatedApp app, PlaywrightElement playwrightElement, IReadOnlyDictionary<string, object> parameters)
//	{
//		if (!parameters.TryGetValue("x", out var x))
//			throw new ArgumentException("X coordinate not found in parameters", nameof(parameters));
//		if (!parameters.TryGetValue("y", out var y))
//			throw new ArgumentException("Y coordinate not found in parameters", nameof(parameters));

//		var touchDevice = new PointerInputDevice(PointerKind.Mouse);
//		var sequence = new ActionSequence(touchDevice, 0);
//		sequence.AddAction(touchDevice.CreatePointerMove(CoordinateOrigin.Viewport, Convert.ToInt32(x), Convert.ToInt32(y), TimeSpan.FromMilliseconds(5)));
//		sequence.AddAction(touchDevice.CreatePointerDown(PointerButton.TouchContact));
//		sequence.AddAction(touchDevice.CreatePointerUp(PointerButton.TouchContact));
//		app.Driver.PerformActions([sequence]);

//		return null;
//	}
//}
