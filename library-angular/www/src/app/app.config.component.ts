import {Component, OnInit} from '@angular/core';
import {AppComponent} from './app.component';
import {AppMainComponent} from './app.main.component';

@Component({
    selector: 'app-config',
    template: 
    ''
})
export class AppConfigComponent implements OnInit {

    themes: any[];

    themeColor = 'blue-grey';

    constructor(public app: AppComponent, public appMain: AppMainComponent) {
    }

    ngOnInit() {
        this.themes = [
            {label: 'blue', color: '#1976d2'},
            {label: 'blue-grey', color: '#607D8B'},
            {label: 'cyan', color: '#0097a7'},
            {label: 'dark-blue', color: '#3e464c'},
            {label: 'dark-green', color: '#2f4050'},
            {label: 'deep-purple', color: '#673ab7'},
            {label: 'green', color: '#43A047'},
            {label: 'indigo', color: '#3f51b5'},
            {label: 'light-blue', color: '#03A9F4'},
            {label: 'teal', color: '#009688'}
        ];
    }

    changeTheme(theme) {
        this.themeColor = theme;
        if (this.app.compactMode) {
            this.changeStyleSheetsColor('theme-css', 'theme-' + theme + '-compact.css');
        } else {
            this.changeStyleSheetsColor('theme-css', 'theme-' + theme + '.css');
        }
        this.changeStyleSheetsColor('layout-css', 'layout-' + theme + '.css');
    }

    changeStyleSheetsColor(id, value) {
        const element = document.getElementById(id);
        const urlTokens = element.getAttribute('href').split('/');
        urlTokens[urlTokens.length - 1] = value;

        const newURL = urlTokens.join('/');

        this.replaceLink(element, newURL);
    }

    isIE() {
        return /(MSIE|Trident\/|Edge\/)/i.test(window.navigator.userAgent);
    }

    replaceLink(linkElement, href) {
        if (this.isIE()) {
            linkElement.setAttribute('href', href);
        } else {
            const id = linkElement.getAttribute('id');
            const cloneLinkElement = linkElement.cloneNode(true);

            cloneLinkElement.setAttribute('href', href);
            cloneLinkElement.setAttribute('id', id + '-clone');

            linkElement.parentNode.insertBefore(cloneLinkElement, linkElement.nextSibling);

            cloneLinkElement.addEventListener('load', () => {
                linkElement.remove();
                cloneLinkElement.setAttribute('id', id);
            });
        }
    }

    changeThemeStyle(event, compactMode) {
        if (compactMode) {
            this.changeStyleSheetsColor('theme-css', 'theme-' + this.themeColor + '-compact.css');
        }
        else {
            this.changeStyleSheetsColor('theme-css', 'theme-' + this.themeColor + '.css');
        }
    }

    onConfigButtonClick(event) {
        this.appMain.configActive = !this.appMain.configActive;
        event.preventDefault();
    }

    onConfigCloseClick(event) {
        this.appMain.configActive = false;
        event.preventDefault();
    }
}
