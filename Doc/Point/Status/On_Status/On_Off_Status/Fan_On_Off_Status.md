[Point](../../../Point.md) > [Status](../../Status.md) > [On_Status](../On_Status.md) > [On_Off_Status](On_Off_Status.md) > [Fan_On_Off_Status](.)
# Fan_On_Off_Status
**DTMI:** dtmi:org:brickschema:schema:Brick:Fan_On_Off_Status;1
## Display name
- **en:** Fan On Off Status
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
