import React from "react";
import "./Dialog.css";

class DialogProps {
  /** @type {string} */
  DialogType;
  /** @type {string} */
  Title;
  /** @type {string} */
  Message;
  /** @type {boolean} */
  Open;
  /** @type {function} */
  OnCancel;
  /** @type {function} */
  OnOk;
}

/**
 * @param {DialogProps} props
 */
export default function Dialog(props) {
  if (!props.Open) {
    return null;
  }

  let footerFragment;

  if (props.DialogType === "confirm") {
    footerFragment = (
      <div className="dialog-footer">
        <button className="btn" onClick={props.OnOk}>
          Ok
        </button>
        <button className="btn" onClick={props.OnCancel}>
          Cancel
        </button>
      </div>
    );
  } else {
    footerFragment = (
      <div className="dialog-footer">
        <button className="btn" onClick={props.OnCancel}>
          Close
        </button>
      </div>
    );
  }

  return (
    <div className="dialog-bg">
      <div className="dialog-wrapper">
        <div className="dialog-header">
          <h3>{props.Title}</h3>
        </div>
        <div className="dialog-body">
          <p>{props.Message}</p>
        </div>
        {footerFragment}
      </div>
    </div>
  );
}
