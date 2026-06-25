# Feature Spec

## Feature List

## F-001: Character Part Drawing

### Purpose

Allow players to create original characters by drawing body parts.

### MVP Requirements

- Player can draw basic humanoid parts.
- Drawn parts are saved as character data.
- Each part can be visually identified.

### Notes

Drawing quality should not need to be perfect. Strange shapes should be allowed because they create funny battle behavior.

## F-002: Character Assembly

### Purpose

Turn drawn parts into a connected physics character.

### MVP Requirements

- Parts are connected into a humanoid structure.
- Character can stand or spawn in the arena.
- Parts can move according to simple commands.

## F-003: Simple Programming Commands

### Purpose

Let players define behavior without writing code.

### MVP Requirements

- Player chooses commands from a list.
- Commands repeat automatically during battle.
- Commands are simple enough for children.

### Command Examples

- punch
- swing
- guard
- kick
- jump
- crouch

## F-004: Automatic Battle

### Purpose

Let drawn characters fight without direct player control.

### MVP Requirements

- Battle starts after drawing and command setup.
- Character acts automatically.
- Battle can end with win/loss/draw.

## F-005: Local Character Save

### Purpose

Allow players to reuse drawn characters.

### MVP Requirements

- Save character data locally.
- Load saved character for battle.

## F-006: Character Sharing

### Purpose

Allow players to share created characters.

### MVP Requirements

- Design data format so sharing is possible later.
- Full online sharing may be implemented after first playable MVP.

## F-007: Online Battle

### Purpose

Allow players to battle against other players.

### MVP Requirements

- Keep online battle as a core product goal.
- Do not design local-only systems that block future online battle.

### Possible Stages

1. Local battle
2. Shared character download battle
3. Asynchronous battle
4. Real-time online battle

## F-008: Monetization

### Purpose

Support sustainable development without pay-to-win.

### MVP Requirements

- Consider monetization in architecture.
- Do not lock core fun behind payment in early design.

### Candidate Paid Content

- additional slots
- cosmetic effects
- extra body types
- drawing materials
