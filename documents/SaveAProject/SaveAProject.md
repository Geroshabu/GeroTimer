# Save a project

## 💬 Use Case Description

### Summary

Save changes of the current project to the storage.

### Actors

* User

### Primary Flows

1. User requests in one of the following ways.
  * User clicks "Save" button on the main window.
  * User selects save at the step 2 of the alternative flow "2-A" of the use case "Create a new project".
2. If save location of the current project is not decided, do following steps to decide it.
  1. The system shows a dialog to specify the save location.
  2. User specifies the save location and file name.
3. The system save the current project to the save location.

### Alternative Flows

#### 2-2-A : If user canceled

1. Abort this use case.

#### 3-A : If any errors occurred

1. The system shows an error dialog according to the error.
2. Abort this use case.

### Pre-condition

* The current project exists.

### Post-condition

* The project file exists at the save location.
