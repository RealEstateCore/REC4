[Point](../../Point.md) > [Status](../Status.md) > [System_Status](System_Status.md) > [Emergency_Air_Flow_System_Status](.)
# Emergency_Air_Flow_System_Status
**DTMI:** dtmi:org:brickschema:schema:Brick:Emergency_Air_Flow_System_Status;1
## Display name
- **en:** Emergency Air Flow System Status
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