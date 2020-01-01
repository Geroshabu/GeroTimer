# Delete a sequence item

## 💬 Use Case Description

### Summary

Delete specified item of the alarm sequence.

### Actors

* User

### Primary Flow

1. User clicks "Delete Item" button of a sequence item on the main window.
2. The system shows the confirmation dialog.
3. User selects a choice.
    * User selects OK
        1. The system closes the confirmation dialog.
    * User selects Cancel
        1. The system closes the confirmation dialog.
        2. Abort this use case.
4. The system removes the item selected at step 1 from the sequence.

### Alternative Flows

There are no flows.

### Pre-condition

* The main window is displaying

### Post-condition

* The selected item is not shown in the main window
