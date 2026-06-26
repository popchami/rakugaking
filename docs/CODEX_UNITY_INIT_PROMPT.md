# Codex Prompt: Initialize Unity Project

Use this prompt in Codex or another AI development environment that can create or edit a Unity project.

## Prompt

```text
You are working in the repository popchami/rakugaking.

Follow ADeL project management files:

- PROJECT_STATE.md
- HANDOFF.md
- NEXT_TASK.md

Current task:
Initialize the Unity project in unity/Rakugaking/.

Requirements:

1. Create or initialize a Unity 3D project at:
   unity/Rakugaking/

2. Use a stable Unity LTS version available in the environment.
   If the Unity version cannot be confirmed, do not guess silently.
   Report the version situation clearly.

3. Do not implement gameplay yet.

4. Do not create battle systems, drawing systems, character programming systems, UI systems, or save systems yet.

5. The only goal is a clean Unity project that can be opened and played.

Done conditions:

- Unity project files exist under unity/Rakugaking/
- The project opens in Unity
- Play mode starts
- No red Console errors appear in the initial scene

After completing the task, update:

- PROJECT_STATE.md
- HANDOFF.md
- NEXT_TASK.md

NEXT_TASK.md should move to:
Create the minimum playable foundation scene.

Report:

- Unity version used
- Project template used
- Files/folders created
- How the owner should check in Unity
```
