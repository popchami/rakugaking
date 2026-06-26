# PROJECT_STATE

## Project Name

rakugaking

## Current Status

Unity Implementation Preparation

## Current Phase

Implementation Preparation

## Purpose

Use ADeL and ADeL for Unity principles to move rakugaking from concept/design into practical Unity development.

## Project Goal

Create and release a Unity game where players draw/program simple characters and make them fight in a chaotic, funny way.

## Current Direction

rakugaking is the real development site.

ADeL is the project flow / site supervisor.

ADeL for Unity is the Unity-specific work manual.

Unity is the main production environment.

## Completed

- Core game concept has been discussed
- ADeL flow is available
- ADeL for Unity repository has been created as an initial draft / reference
- Decision made: real development progress should be managed inside this rakugaking repository
- Unity project structure has been decided
- `docs/` directory has been created
- `unity/Rakugaking/` directory has been created as the Unity project location

## Not Completed Yet

- Unity version is not confirmed
- Unity project files are not created yet
- First Unity scene is not created
- Playable prototype is not created
- Release path is not defined in detail

## Repository Structure

```text
rakugaking/
├── PROJECT_STATE.md
├── HANDOFF.md
├── NEXT_TASK.md
├── docs/
└── unity/
    └── Rakugaking/
```

## Current Rule

Do not add new specification documents during Implementation unless absolutely necessary.

Use these files for ongoing progress:

- PROJECT_STATE.md
- HANDOFF.md
- NEXT_TASK.md

## Human Role

The owner does not need to read code.

The owner checks:

- Is Unity Play mode working?
- Are there red Console errors?
- Does the game behavior match the intended result?
- Is the current task OK or NG?

## AI Role

AI should:

- Check PROJECT_STATE.md
- Check HANDOFF.md
- Check NEXT_TASK.md
- Choose or complete only one next task at a time
- Avoid guessing unconfirmed specifications
- Update the state after meaningful progress
- Provide beginner-checkable Unity confirmation steps

## Current Next Step

Follow NEXT_TASK.md.
