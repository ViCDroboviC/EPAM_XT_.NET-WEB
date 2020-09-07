
const DOMMap = {
    noteSheetId: 'noteSheet',
    addButtonId: 'add'
}

const notesCollection = [];

let noteId = 0;

let noteSheet = document.getElementById(DOMMap.noteSheetId);
let addButton = document.getElementById(DOMMap.addButtonId);

var show = function(state){
    document.getElementById('modalForm').style.display = state;
    document.getElementById('filter').style.display = state;
}

var AddNote = function(){
    var newNoteHead = GetNoteHead();
    var newNoteText = GetNoteText();

    var newNote = {
        id: noteId,
        head: newNoteHead,
        text: newNoteText
    };

    /*notesCollection.append(newNote);*/

    console.log(newNote);

    var newNote = CreateNote(newNote.id, newNote.head, newNote.text);
    noteSheet.appendChild(newNote);

    noteId++;
}

var CreateNote = function(Id, head, text){
    var newNote = document.createElement('div');
    newNote.setAttribute('id', Id);

    var newHead = CreateHead(head);
    newNote.appendChild(newHead);

    var newText = CreateText(text);
    newNote.appendChild(newText);

    var deleteButton = CreateButton('delete', 'onclick', 'DeleteNote(this)');
    newNote.appendChild(deleteButton);

    newNote.appendChild(document.createElement('hr'));
    return newNote;
}

var CreateHead = function(head){
    var newHead = document.createElement('h2');
    newHead.innerHTML = head;
    return newHead;
}

var CreateText = function(text){
    console.log("Entered in CreateText: " + text);
    var newText = document.createElement('p');
    newText.innerHTML = text;
    return newText;
}

var CreateButton = function(buttonClass, attribute, attributeValue){
    var newButton = document.createElement('button');
    newButton.className = buttonClass;
    newButton.setAttribute(attribute, attributeValue);
    return newButton;
}

var GetNoteHead = function(){
    return document.getElementById('Head').value;
}

var GetNoteText = function(){
    return document.getElementById("newNote").value;
}

var DeleteNote = function(note){
    note.parentNode.remove();
}

addButton.onclick = AddNote;
