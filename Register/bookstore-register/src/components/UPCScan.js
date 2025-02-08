import React from "react";

class UPCScanProps {
    onSubmit;
}

/** @param {UPCScanProps} props */
export default function UPCScan(props) {

    const [errorMessage, setErrorMessage] = React.useState('');
    const inputRef = React.useRef(null)

    const onKeyDown = async (e) => {
        if (e.key === 'Enter') {
            try{
                inputRef.current.setAttribute('disabled', 'true');
                await props.onSubmit(e.target.value);
                e.target.value = '';
                setErrorMessage('');     
            } catch(err){
                console.error(err);          
                setErrorMessage(err.message);      
            } finally {
                inputRef.current.removeAttribute('disabled');
                inputRef.current.select();
            }
        }
    }   

  return (
    <>
      <div className="label-title-row">
        <label className="label-input" for="product-barcode">
          <strong className="strong-label">Item UPC</strong>
        </label>
      </div>
      <input type="text" ref={inputRef} id="product-barcode" placeholder="Scan or enter an item upc" onKeyDown={onKeyDown} />
      <p id="error-text" className="error-text" style={{minHeight: "1.5em"}}>{errorMessage}</p>
    </>
  );
}
