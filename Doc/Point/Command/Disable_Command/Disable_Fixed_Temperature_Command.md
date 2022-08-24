[Point](../../Point.md) > [Command](../Command.md) > [Disable_Command](Disable_Command.md) > [Disable_Fixed_Temperature_Command](.)
# Disable_Fixed_Temperature_Command
**DTMI:** dtmi:org:brickschema:schema:Brick:Disable_Fixed_Temperature_Command;1
## Display name
- **en:** Disable Fixed Temperature Command
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
