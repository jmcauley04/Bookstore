import React from 'react'
import "./Banner.css"

class BannerProps {
    /** @type {string} */
    bgColor;
    /** @type {string} */
    fgColor;
    /** @type {string} */
    text;
    /** @type {string} */
    url;
}

/** @param {BannerProps} bannerProps  */
export default function Banner(bannerProps) {
    const bgColor = bannerProps.bgColor ?? '#000000';
    const fgColor = bannerProps.fgColor ?? '#ffffff';
    const text = bannerProps.text ?? '';

    const style = {
        backgroundColor: bgColor,
        color: fgColor
    };

  return (
    <div className='banner-wrapper'>
        <div className='banner' style={style}>
            <div className='banner-text'>
                <span>{text}</span>
            </div>
        </div>
    </div>
  )
}
