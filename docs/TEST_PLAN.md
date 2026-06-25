# Test Plan

## Purpose

Define how to verify the rakugaking MVP.

## MVP Test Goal

The MVP passes when a player can create a drawn character and complete a battle with a result.

## Test Areas

## 1. Drawing Tests

Verify:

- player can draw each required body part
- drawing can be cleared/redrawn
- drawing is saved correctly
- drawing appears in preview

## 2. Assembly Tests

Verify:

- all required parts connect into a character
- character spawns in the arena
- missing or strange parts do not crash the game
- character can fall or move without breaking the simulation

## 3. Command Tests

Verify:

- commands can be assigned through simple UI
- no code input is required
- assigned commands execute during battle
- repeated commands do not freeze the game

## 4. Battle Tests

Verify:

- battle starts successfully
- both characters act automatically
- camera can show the fight
- battle can end
- result is displayed

## 5. Save / Load Tests

Verify:

- character can be saved
- saved character can be loaded
- loaded character can battle

## 6. Platform Tests

Verify on target platforms when available:

- smartphone touch input
- PC mouse input
- screen layout readability
- performance in battle

## 7. Future-Readiness Checks

Before moving beyond MVP, verify:

- character data can be serialized
- character data can be shared later
- online battle is not blocked by architecture
- monetization is not tied to direct battle strength

## Acceptance Criteria

MVP is acceptable when:

- one complete character can be created
- commands can be assigned
- a battle can start and finish
- result is shown
- the experience is understandable without reading code
- the battle produces funny, readable chaos

## Known Risks to Test Early

- drawing-to-3D conversion is too hard
- physics character collapses immediately every time
- command behavior is unreadable
- smartphone drawing controls feel difficult
- online battle scope becomes too large too early
