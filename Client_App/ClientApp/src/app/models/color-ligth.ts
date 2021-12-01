import { eColor } from "./e-color";
import { eGroups } from "./e-groups";

export interface ColorLigth{
    id?: number;
    clientId?: string;
    groupId?: eGroups;
    color?: eColor;
}