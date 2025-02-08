import React from 'react'
import "./Hero.css"
import Logo from './Logo'

export default function Hero() {
  return (
    <div className='hero hero-wrapper'>
        <div className='hero-background'>
            <div className='hero-sign'>
                <Logo />
            </div>
        </div>
    </div>
  )
}
