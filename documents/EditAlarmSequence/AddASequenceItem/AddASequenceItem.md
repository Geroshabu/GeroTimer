# Add a sequence item

## 💬 Use Case Description

### Summary



### Actors

* User

### Primary Flow

1. User clicks "New Project" button on the main window.
2. If the current project exists, the system checks if there are some changes which haven't save yet.
3. The system creates a new project as the current project.
4. The system refresh the screen.

### Alternative Flows

#### 2-A : If there are unsaved changes

1. The system shows the dialog asking whether to save, discard, or cancel.
2. User selects a choice.
  * User selects save
    1. Execute the use case "Save a project".
    2. If the use case "Save a project" was aborted, abort this use case.
  * User selects discard
    1. Nothing  to do.
  * User selects cancel
    1. Abort this use case.
3. Back to step 3 of primary flow.

### Pre-condition

* The main window is displaying

### Post-condition

* The main window is displaying according to the new project
