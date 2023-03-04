
function sendApprovalLetter(name) {
    console.log(`Sending approval letter to ${name}.`);
}

function sendDenialLetter(name) {
    console.log(`Sending denial letter to ${name}.`);
}

customer = {
    name: '',
    isApproved: false,
    sendResultLetter() {
        this.isApproved ? sendApprovalLetter(this.name) : sendDenialLetter(this.name);
    }
}

customer.name = 'Mark';
customer.isApproved = true;
customer.sendResultLetter();
