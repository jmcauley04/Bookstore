import React from "react";

export default function EmailInput() {
  var [sent, setSent] = React.useState(false);

  const sendEmailAddress = async () => {
    /** @type {HTMLInputElement} */
    var emailElement = document.getElementById("email-input");

    if (emailElement.value) {
        fetch("https://api.swampsofdouglas.mywire.org/friend-forms/bookstore-coming-soon", {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify({
            formId: "bookstore-coming-soon",
            submitter: emailElement.value,
            data: {}
          }),
        });
      setSent(true);
    } else {
      alert("Please enter an email address");
    }
  };

  if (sent) {
    return (
      <div style={{ paddingTop: "1em", textWrap: "wrap", width: "300px" }}>
        Thanks for signing up for our email list!
      </div>
    );
  }

  return (
    <>
      <div style={{ paddingTop: "1em", textWrap: "wrap", width: "300px" }}>
        While you wait, please sign up for our email list for updates!
      </div>
      <form onSubmit={sendEmailAddress} className="notify">
        <input type="email" id="email-input" placeholder="Email*" />
        <button type="submit">Notify me</button>
      </form>
    </>
  );
}
