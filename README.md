# UnoButtonOnLayeredCanvasIssue
Issue reported on Uno Platform where buttons on a layered Canvas do not fire.
Reported as issue #12723

Issue Title:
[Android, iOS] When a control containing a button on a canvas is placed on a canvas the button will not fire
Description:
When layering controls on a grid it can be advantageous to place the layered controls on a canvas to avoid confusing the layout algorithm determination of the positions if using center alignment.
If the layered control contains buttons on a canvas, these do not fire on Android and iOS.
The issue does not occur on Windows and WASM.

Expected results
The button on the control should still fire.

Reproduced
Sample available at https://github.com/BrianDT/UnoButtonOnLayeredCanvasIssue

Workaround
Re-architect application structure

