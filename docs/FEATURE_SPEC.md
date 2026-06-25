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

## F-006: Online Battle

### Purpose

Allow players to battle against other players.

### MVP Requirements

- Keep online battle as a core product goal.
- Do not design local-only systems that block future online battle.
- Character data may be transferred temporarily inside an online match if needed.

### Possible Stages

1. Local battle
2. Local saved character battle
3. Private room online battle
4. Random matchmaking
5. Real-time online battle if feasible

## F-007: Monetization

### Purpose

Support sustainable development without pay-to-win.

### MVP Requirements

- Consider monetization in architecture.
- Do not lock core fun behind payment in early design.

### Candidate Paid Content

- additional character slots
- cosmetic effects
- extra body types
- drawing materials

## Postponed Features

The following are intentionally postponed:

- public character sharing
- public character gallery
- share codes
- user-facing character export/import
- browsing other players' characters
