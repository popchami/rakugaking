# Drawing Spec

## Purpose

Define how drawing works in the first playable MVP.

## Design Goal

Drawing should feel simple and playful.

The player should feel that their drawing becomes the fighter.

## First MVP Drawing Method

The recommended first MVP method is:

- draw body parts in 2D
- apply the drawing to simple 3D physics parts
- use drawing size/shape to influence part values where possible

This avoids starting with complex direct 3D sculpting.

## Drawing Flow

1. Choose body part.
2. Draw inside a guide area.
3. Confirm or redraw.
4. Move to next body part.
5. Preview full character.

## MVP Drawing Tools

Minimum tools:

- brush
- eraser
- clear
- undo if feasible
- confirm part

Optional later:

- color palette
- stamps
- fill tool
- decorations
- symmetry

## Guide Areas

Each body part should have a simple guide area.

The guide should help the player understand the part, but not force perfect drawing.

## Shape Influence

The drawing may influence:

- part length
- part width
- mass
- collider size
- reach
- stability

## Limits

Some limits are needed so the game does not break.

Possible limits:

- minimum part size
- maximum part size
- auto-centering
- simple collider generation
- fallback shape if drawing is empty

## Empty Drawing Handling

If a player does not draw a part, the game should not crash.

Possible behavior:

- use default placeholder part
- ask player to draw again
- allow missing part only in later experimental mode

## Smartphone Requirements

- touch input must feel natural
- buttons must be large
- accidental touches should be easy to fix
- drawing area must not be too small

## PC Requirements

- mouse input works
- window size should not break the drawing UI

## Future Drawing Ideas

- true 3D drawing
- clay-like sculpting
- body type-specific guides
- shared drawing templates
- premium drawing tools
