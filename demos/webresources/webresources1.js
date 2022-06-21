
var checkinFormNameSpace = window.checkinFormNameSpace || {};
(
  function () {
    this.OnFirstNameChange = function () {
      alert('The first name was changed');
    }

    this.OnOvertimePay = function (executionContext) {
      console.log('Hey there! I\'m your friendly neighborhood web resource!');
      let fc = executionContext.getFormContext(); // get formContext
      let typeOfCheckin = fc.getAttribute("mm_typeofcheckin").getValue();

      if (typeOfCheckin === 930720003) { // Overtime Pay
        fc.getAttribute('mm_hourlypay').setValue(10000);
      }

      if (typeOfCheckin === 930720004) { // Holiday Pay
        fc.getAttribute('mm_hourlypay').setValue(20000);
      }

      if (typeOfCheckin === 930720005) { // Regular Pay
        fc.getAttribute('mm_hourlypay').setValue(30000);
      }
    }
  }
).call(checkinFormNameSpace);









