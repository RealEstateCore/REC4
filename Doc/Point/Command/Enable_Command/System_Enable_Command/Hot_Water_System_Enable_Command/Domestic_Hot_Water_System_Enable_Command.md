[Point](../../../../Point.md) > [Command](../../../Command.md) > [Enable_Command](../../Enable_Command.md) > [System_Enable_Command](../System_Enable_Command.md) > [Hot_Water_System_Enable_Command](Hot_Water_System_Enable_Command.md) > [Domestic_Hot_Water_System_Enable_Command](.)
# Domestic_Hot_Water_System_Enable_Command
**DTMI:** dtmi:org:brickschema:schema:Brick:Domestic_Hot_Water_System_Enable_Command;1
## Display name
- **en:** Domestic Hot Water System Enable Command
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