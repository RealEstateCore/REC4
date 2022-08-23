# Agent
**DTMI:** dtmi:org:w3id:rec:Agent;1
## Display name
- **en:** Agent
## Description
- **en:** The human, group, or machine that consumes or acts upon an object or data. This higher-level grouping allows properties that are shared among its subclasses (Person, Organization, ....) to be anchored in one joint place, on the Agent class.
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|isMemberOf|**en**: is member of|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic Organization.isPartOf property.|0-Infinity|dtmi:org:w3id:rec:Organization;1||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||TBD|True|
|externalIds|**en**: External IDs||TBD|True|
|name|**en**: name||TBD|True|
