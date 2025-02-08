import React from 'react'
import "./SplitContent.css"

export default function SplitContent({ image, text, title, url, imageOnLeft }) {
    return (
        <div className='split-content-wrapper'>
            {imageOnLeft && (
                <div className='img' style={{ backgroundImage: `url(${image})` }}>
                </div>
            )}
            <div className='text'>
                <h2>{title}</h2>
                <p>{text}</p>
                <div className='button'>Learn More</div>
            </div>
            {!imageOnLeft && (
                <div className='img' style={{ backgroundImage: `url(${image})` }}>
                </div>
            )}
        </div>
    );
}
