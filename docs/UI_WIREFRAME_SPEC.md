# UI Wireframe Spec

## Purpose

Define simple text wireframes for rakugaking MVP screens.

These are not final designs. They are implementation guides.

## UI Principle

The UI should feel like a toy.

Avoid developer-like terminology.

Use large buttons, short labels, and clear next actions.

## Home Screen

```txt
+--------------------------------+
| rakugaking                     |
|                                |
| [Create Character]             |
| [Local Battle]                 |
| [Online Battle] (future)       |
| [Settings]                     |
|                                |
| Saved Characters               |
| - Character 1                  |
| - Character 2                  |
+--------------------------------+
```

## Character Create Screen

```txt
+--------------------------------+
| Draw Character                 |
| Part: Left Arm                 |
|                                |
| +--------------------------+   |
| |                          |   |
| |      Drawing Area        |   |
| |                          |   |
| +--------------------------+   |
|                                |
| [Brush] [Eraser] [Clear]       |
|                                |
| [Back]              [Confirm]  |
+--------------------------------+
```

## Part Progress UI

```txt
Head  Body  L.Arm  R.Arm
L.Leg R.Leg L.Foot R.Foot
```

Each part should show:

- not started
- completed
- current

## Character Preview Screen

```txt
+--------------------------------+
| Preview                        |
|                                |
|        [3D Character]          |
|                                |
| This looks weird? That's OK.   |
|                                |
| [Redraw Part] [Commands]       |
+--------------------------------+
```

## Command Setup Screen

```txt
+--------------------------------+
| Set Commands                   |
| Selected Part: Right Arm       |
|                                |
| [Punch] [Swing] [Guard]        |
|                                |
| Selected Part: Right Leg       |
|                                |
| [Kick] [Jump] [Crouch]         |
|                                |
| [Back]          [Start Battle] |
+--------------------------------+
```

## Battle Screen

```txt
+--------------------------------+
| You HP: 100     Enemy HP: 100  |
| Time: 60                       |
|                                |
|                                |
|          [Battle Arena]        |
|                                |
|                                |
| [Pause]                        |
+--------------------------------+
```

## Result Screen

```txt
+--------------------------------+
| Result                         |
|                                |
| Winner: You                    |
| Reason: Ring Out               |
|                                |
| [Rematch]                      |
| [Edit Commands]                |
| [Edit Character]               |
| [Home]                         |
+--------------------------------+
```

## Mobile UI Rules

- Buttons must be large enough for touch.
- Drawing area must be the main focus.
- Avoid small sliders in the first MVP.
- Do not require keyboard input except character name.

## PC UI Rules

- Mouse input should work for drawing.
- Screen should remain readable in windowed mode.

## Wording Rules

Prefer:

- Draw
- Move
- Fight
- Try Again

Avoid:

- compile
- script
- node
- parameter
- physics coefficient

## Related Docs

- `docs/UI_UX_SPEC.md`
- `docs/SCENE_FLOW_SPEC.md`
- `docs/COMMAND_SPEC.md`
