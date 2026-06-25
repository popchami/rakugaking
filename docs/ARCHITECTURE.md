# Architecture

## Technology Stack

- Engine: Unity
- Target Platforms: Smartphone and PC
- Language: C#

## Architecture Principle

Build the game in stages.

Do not start with complex online systems before the core drawing-to-battle loop works.

However, do not design the project in a way that blocks online battle, character sharing, or monetization later.

## High-Level Modules

## 1. Drawing Module

Responsibilities:

- capture player drawing input
- store drawing data
- generate visual body parts
- provide part preview

## 2. Character Assembly Module

Responsibilities:

- connect drawn parts
- create a physics-based character
- assign body part metadata
- prepare character for battle

## 3. Command Module

Responsibilities:

- define simple commands
- assign commands to parts
- execute commands repeatedly during battle

## 4. Battle Module

Responsibilities:

- spawn characters
- run automatic battle
- evaluate win/loss/draw
- manage timer and arena rules

## 5. Save Data Module

Responsibilities:

- save characters locally
- load characters
- prepare export/import format for sharing

## 6. Online Module

Responsibilities for future phases:

- upload character data
- download shared characters
- match players
- synchronize or simulate battles

Online should be planned early but implemented after the local battle loop is validated unless explicitly approved.

## 7. Monetization Module

Responsibilities for future phases:

- manage owned content
- unlock cosmetics or slots
- integrate store systems

Monetization must not affect battle strength directly.

## Suggested Development Order

1. Unity project setup
2. simple battle arena
3. test physics character with placeholder parts
4. command execution prototype
5. drawing input prototype
6. drawing-to-part conversion
7. local save/load
8. local character vs character battle
9. sharing data format
10. online and monetization design

## Design Risks

### Drawing to 3D Conversion

This is the largest technical risk.

The project must decide whether the MVP uses:

- 2D drawing mapped onto flat 3D parts
- generated mesh from strokes
- voxel/clay-like 3D drawing
- preset 3D parts with drawn textures

### Physics Stability

The game needs messy movement, but not broken movement.

Characters should fail in funny ways, not in unreadable ways.

### Online Battle

Real-time physics synchronization can be difficult.

Possible safer options:

- asynchronous battle
- shared character data with local simulation
- deterministic replay-style battle

## Current Recommendation

For first playable MVP, prefer:

- local-first battle
- simple humanoid skeleton
- drawn textures or simple generated shapes
- command buttons rather than visual scripting
- sharing-ready character data format
