import { ReactComponent as Facebook } from '../images/social/facebook.svg'
import { ReactComponent as Instagram } from '../images/social/instagram.svg'
import { ReactComponent as TikTok } from '../images/social/tiktok.svg'
import { ReactComponent as LinkedIn } from '../images/social/linkedin.svg'
import React from 'react'
import './Connect.css'

export default function Connect() {
  return (
    <div style={{display: "flex", gap: "1em", justifyContent: "center", alignItems: "center"}}>
        <div className='connect-row'>
            <div>
                <Instagram />
            </div>
            <div>
                <TikTok />
            </div>
            <div>
                <Facebook />
            </div>
            <div>
                <LinkedIn />
            </div>
        </div>
    </div>
  )
}
