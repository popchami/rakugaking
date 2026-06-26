# NEXT_TASK

## Project

rakugaking

## Current Phase

Implementation Preparation

## Current Unity Implementation Phase

Phase 0 - Project Setup

## Next Task

Decide the Unity project structure.

## Goal

Decide where the Unity project will live inside this repository and what the initial Unity setup should look like.

## Scope

This task may decide:

- Unity project folder name
- Whether the Unity project lives at repository root or inside a subfolder
- Initial folder structure
- Minimum files/docs needed before creating the Unity project

## Out of Scope

Do not implement gameplay yet.

Do not create battle systems yet.

Do not create character drawing systems yet.

Do not add multiple new specification documents.

## Proposed Direction

Use a dedicated Unity project folder:

```text
rakugaking/
├── PROJECT_STATE.md
├── HANDOFF.md
├── NEXT_TASK.md
├── docs/
└── unity/
    └── Rakugaking/
```

Reason:

Keeping the Unity project inside `unity/Rakugaking/` separates Unity-generated files from ADeL management files.

## Done Conditions

This task is complete when:

- The Unity project location is decided
- The initial repository structure is decided
- The next actual Unity creation task is clear

## Next Task After This

Create or initialize the Unity project using the decided structure.
