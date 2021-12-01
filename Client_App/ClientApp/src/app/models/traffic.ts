import { eGroups } from "./e-groups";

export interface Traffic{
    id?: number;
    clientId?: string;
    groupId?: eGroups;
    numberFails?: number;
    numberLigths?: number;
}