
/*const DOMMap = {
    addButtonId: 'add'
}*/

let noteId = 0;
let noteSheet = document.getElementById('noteSheet');
let addButton = document.getElementById('add');

var show = function(state){
    document.getElementById('modalForm').style.display = state;
    document.getElementById('filter').style.display = state;
}

var AddNote = function(){
    console.log("work!")

    var newNoteHead = GetNoteHead();
    var newNoteText = GetNoteText();
    var newNote = CreateNote(noteId, newNoteHead, newNoteText);
    noteSheet.appendChild(newNote);

    console.log(newNoteHead);
    console.log(newNoteText);
    noteId++;
}

var CreateNote = function(Id, head, text){
    console.log("Entered in CreateNode: " + Id + head + text);
    var newNote = document.createElement('div');
    newNote.setAttribute('id', Id);

    var newHead = CreateHead(head);
    newNote.appendChild(newHead);

    var newText = CreateText(text);
    newNote.appendChild(newText);

    newNote.appendChild(document.createElement('hr'));
    return newNote;
}

var CreateHead = function(head){
    console.log("Entered in CreateHead: " + head);
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

var GetNoteHead = function(){
    return document.getElementById('Head').value;
}

var GetNoteText = function(){
    return document.getElementById("newNote").value;
}

addButton.onclick = AddNote;
