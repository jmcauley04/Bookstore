import React from 'react'
import "./CenterContent.css"

export default function CenterContent({ text, title, bgFilled }) {
    return (
        <div className={bgFilled ? 'center-content-wrapper bg-filled' : 'center-content-wrapper'}>
            <div className='text'>
                <h2>{title}</h2>
                <p>{text}</p>
            </div>
        </div>
    );
}
