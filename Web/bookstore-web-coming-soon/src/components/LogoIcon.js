import React from "react";

export default function LogoIcon() {
  return (
    <svg
      xmlns="http://www.w3.org/2000/svg"
      viewBox="7.5 10 85 80"
      fill="currentColor"
    >
      <mask id="mask1" maskUnits="userSpaceOnUse">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <circle r="1" fill="black" cy="14" />
        <circle r="1" fill="black" cy="28" />
        <circle r=".5" fill="black" cy="25" />
        <circle r=".5" fill="black" cy="21" />
        <circle r=".5" fill="black" cy="17" />
      </mask>
      <mask id="mask2" maskUnits="userSpaceOnUse">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <rect x="-2" y="16" width="4" height="1" fill="black" rx=".5" />
      </mask>
      <mask id="mask3" maskUnits="userSpaceOnUse">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <circle r="1" fill="black" cy="14" />
        <circle r="1" fill="black" cy="28" />
      </mask>
      <mask id="mask4" maskUnits="userSpaceOnUse">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <circle r="1" fill="black" cy="16" />
        <rect x="-3" y="28" width="6" height="1" fill="black" />
      </mask>
      <mask id="mask5" maskUnits="userSpaceOnUse">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <rect x="-1.5" y="16" width="3" height="1" fill="black" rx=".5" />
        <rect x="-1.5" y="28" width="3" height="1" fill="black" rx=".5" />
      </mask>
      <mask id="mask6" maskUnits="userSpaceOnUse" stroke-width=".5">
        <rect x="-10" y="-10" width="110" height="110" fill="white" />
        <path
          d="M67.5 19.5 c-5 -2 -1 -6 0 -7 c1 1 5 5 0 7 "
          fill="none"
          stroke="black"
        />
      </mask>

      <g stroke="currentColor" transform="translate(-1,0)">
        <g transform="translate(14,0)" stroke-width="3">
          <line y1="30" y2="17" />
          <line y1="16" y2="15" />
        </g>
        <g transform="translate(18,0)" stroke-width="4">
          <line y1="30" y2="12" mask="url(#mask1)" />
        </g>
        <g transform="translate(23,0)" stroke-width="5">
          <line y1="30" y2="15" />
          <line y1="14.2" y2="14.8" />
          <line y1="14" y2="13" />
        </g>
        <g transform="translate(45,4), rotate(35)" stroke-width="5">
          <line y1="30" y2="15" mask="url(#mask2)" />
        </g>
        <g transform="translate(48,2.6), rotate(27)" stroke-width="3">
          <line y1="30" y2="13" />
        </g>
        <g transform="translate(53,2), rotate(27)" stroke-width="5">
          <line y1="30" y2="20" />
          <line y1="19.2" y2="17" />
        </g>
        <g transform="translate(49,0)" stroke-width="3">
          <line y1="30" y2="13" />
        </g>
        <g transform="translate(53,0)" stroke-width="4">
          <line y1="30" y2="16" />
        </g>
        <g transform="translate(58,0)" stroke-width="5">
          <line y1="30" y2="12" mask="url(#mask3)" />
        </g>
        <g transform="translate(91,27.5), rotate(90)" stroke-width="5">
          <line y1="30" y2="14" mask="url(#mask4)" />
        </g>
        <g transform="translate(79,0)" stroke-width="3">
          <line y1="30" y2="12" />
        </g>
        <g transform="translate(83,0)" stroke-width="4">
          <line y1="30" y2="11" />
        </g>
        <g transform="translate(84,0), rotate(-10)" stroke-width="4">
          <line y1="30" y2="15" mask="url(#mask5)" />
        </g>
      </g>

      <path d="M62 19.5 l11 0 0 3.5 q-.5 .75 -1 1.5 l -9 0 q-.5 -.75 -1 -1.5" />
      <g mask="url(#mask6)">
        <path d="M67.5 19.5 c-5 -2 -1 -6 0 -7 c1 1 5 5 0 7 " />
        <path d="M67.5 19.5 c-5 -2 -1 -6 0 -7 c1 1 5 5 0 7 " transform="translate(-7, -24.7), rotate(45)"
            transform-origin="center" />

        <path d="M67.5 19.5 c-5 -2 -1 -6 0 -7 c1 1 5 5 0 7 " transform="translate(21.3, 10.7), rotate(-45)"
            transform-origin="center" />
      </g>
     
      <rect x="10" width="80" y="30" height="2" />
     <g transform="scale(1.3, .8) translate(-11.5, 9)">
        <g>
          <rect x="34" y="32.5" height="13" width="2" />
          <rect x="64" y="32.5" height="13" width="2" />
        </g>
        <g>
          <circle cx="35" cy="48" r="2" />
          <circle cx="65" cy="48" r="2" />
        </g>
        <g stroke="currentColor" stroke-width="2" stroke-linecap="round">
          <line x1="34.5" x2="32" y1="51.5" y2="68" />
          <line x1="65.5" x2="68" y1="51.5" y2="68" />
        </g>
    </g>

      <g transform="scale(1.3) translate(-11.5, -20.5)">
        <g>
          <rect x="30" y="69" width="5" height="3" />
          <rect x="65" y="69" width="5" height="3" />
          <rect x="66" y="72.5" width="2.5" height="14" />
          <rect x="31.5" y="72.5" width="2.5" height="14" />
        </g>
        <g>
          <rect x="35" y="62.5" width="2.5" height="17" />
          <rect x="62.5" y="62.5" width="2.5" height="17" />
          <rect x="38" y="64.5" width="24" height="3" />
          <rect x="41" y="64.5" width="3" height="15" />
          <rect x="56" y="64.5" width="3" height="15" />
          <rect x="48" y="64.5" width="4" height="15" />
        </g>
        <rect x="34.5" width="31" y="80" height="4" />
      </g>
    </svg>
  );
}
