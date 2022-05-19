let FileSaver = require('fs');

//console.log('hello world');

//figure out how JS does I/O
const downloadToFile = (content, filename, contentType) => {
  const a = document.createElement('a');
  // var blob = new Blob([content], { type: "text/plain;charset=utf-8" });
  FileSaver.appendFile(filename, `\n${content}`, 'utf-8', (err) => {
    if (err) throw err;
    // if no error
    console.log("Data is appended to file successfully.")
  });

  // a.href = URL.createObjectURL(file);
  // a.download = filename;
  // a.click();
  // URL.revokeObjectURL(a.href);//delete the element
};


document.querySelector('#btnSave').addEventListener('click', () => {
  const textArea = document.querySelector('textarea');

  downloadToFile(textArea.value, 'MyToDos.txt', 'text/plain');
});



//const file = new Blob([content], { type: contentType });
