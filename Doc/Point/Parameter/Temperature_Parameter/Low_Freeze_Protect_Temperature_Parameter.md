[Point](../../Point.md) > [Parameter](../Parameter.md) > [Temperature_Parameter](Temperature_Parameter.md) > [Low_Freeze_Protect_Temperature_Parameter](.)
# Low_Freeze_Protect_Temperature_Parameter
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Freeze_Protect_Temperature_Parameter;1
## Display name
- **en:** Low Freeze Protect Temperature Parameter
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